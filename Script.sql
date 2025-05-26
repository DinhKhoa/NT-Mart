--[Tạo table Users]
CREATE TABLE Users
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Tai_Khoan VARBINARY(MAX),
	Mat_Khau VARBINARY(MAX)
)

--[Tạo chứng chỉ]
CREATE CERTIFICATE CertUser WITH SUBJECT = 'Certificate_Users'
--[Tạo khóa đối xứng]
CREATE SYMMETRIC KEY KeyUser
WITH ALGORITHM = AES_256
ENCRYPTION BY CERTIFICATE CertUser

--[Mã hóa để xem] 
OPEN SYMMETRIC KEY KeyUser DECRYPTION BY CERTIFICATE CertUser
SELECT ID, CAST(DECRYPTBYKEY(Tai_Khoan) AS NVARCHAR(50)) 'Tai khoan', CAST(DECRYPTBYKEY(Mat_Khau) AS NVARCHAR(50)) 'Mat khau' FROM Users
CLOSE SYMMETRIC KEY KeyUser

--[SP cho C# check Login]
CREATE OR ALTER PROCEDURE sp_CheckUsersForLogin (@Username NVARCHAR(50), @Password NVARCHAR(50), @ketQuaTraVe BIT OUT)
AS
BEGIN
	-- Kiểm tra đầu vào NULL
	IF @Username IS NULL OR @Password IS NULL
	BEGIN
		SET @ketQuaTraVe = 0
		RETURN
	END

	-- Kiểm tra độ dài
	IF LEN(@Username) > 50 OR LEN(@Password) > 50
	BEGIN
		SET @ketQuaTraVe = 0
		RETURN
	END

	-- Kiểm tra ký tự hợp lệ cho Username (chỉ chữ, số, _, @, !, #, $)
	IF @Username NOT LIKE '%[a-zA-Z0-9_@!#$]%' OR @Username LIKE '%[^a-zA-Z0-9_@!#$]%'
	BEGIN
		SET @ketQuaTraVe = 0
		RETURN
	END

	-- Kiểm tra ký tự hợp lệ cho Password (chỉ chữ, số, _, @, !, #, $)
	IF @Password NOT LIKE '%[a-zA-Z0-9_@!#$]%' OR @Password LIKE '%[^a-zA-Z0-9_@!#$]%'
	BEGIN
		SET @ketQuaTraVe = 0
		RETURN
	END

	OPEN SYMMETRIC KEY KeyUser DECRYPTION BY CERTIFICATE CertUser
	-- Kiểm tra sự tồn tại của Username
	IF NOT EXISTS (SELECT 7 FROM Users WHERE CAST(DECRYPTBYKEY(Tai_Khoan) AS NVARCHAR(50)) = @Username AND CAST(DECRYPTBYKEY(Mat_Khau) AS NVARCHAR(50)) = @Password)
	BEGIN
		SET @ketQuaTraVe = 0
		RETURN
	END
	CLOSE SYMMETRIC KEY KeyUser
	SET @ketQuaTraVe = 1
END


--[SP cho SQL check để insert vào]
CREATE OR ALTER PROCEDURE sp_CheckUsers (@Username NVARCHAR(50), @Password NVARCHAR(50), @ketQuaTraVe BIT OUT)
AS
BEGIN
	-- Kiểm tra đầu vào NULL
	IF @Username IS NULL OR @Password IS NULL
	BEGIN
		PRINT N'---- Thông báo lỗi: Tên người dùng hoặc mật khẩu không được để trống! ----'
		SET @ketQuaTraVe = 0
		RETURN
	END

	-- Kiểm tra độ dài
	IF LEN(@Username) > 50 OR LEN(@Password) > 50
	BEGIN
		PRINT N'---- Thông báo lỗi: Tên người dùng hoặc mật khẩu vượt quá độ dài cho phép! ----'
		SET @ketQuaTraVe = 0
		RETURN
	END

	-- Kiểm tra ký tự hợp lệ cho Username (chỉ chữ, số, _, @, !, #, $)
	IF @Username NOT LIKE '%[a-zA-Z0-9_@!#$]%' OR @Username LIKE '%[^a-zA-Z0-9_@!#$]%'
	BEGIN
		PRINT N'---- Thông báo lỗi: Tên người dùng chứa ký tự không hợp lệ. Chỉ cho phép chữ, số, _, @, !, # và $! ----'
		SET @ketQuaTraVe = 0
		RETURN
	END

	-- Kiểm tra ký tự hợp lệ cho Password (chỉ chữ, số, _, @, !, #, $)
	IF @Password NOT LIKE '%[a-zA-Z0-9_@!#$]%' OR @Password LIKE '%[^a-zA-Z0-9_@!#$]%'
	BEGIN
		PRINT N'---- Thông báo lỗi: Mật khẩu chứa ký tự không hợp lệ. Chỉ cho phép chữ, số, _, @, !, # và $! ----'
		SET @ketQuaTraVe = 0
		RETURN
	END

	OPEN SYMMETRIC KEY KeyUser DECRYPTION BY CERTIFICATE CertUser
	-- Kiểm tra sự tồn tại của Username
	IF EXISTS (SELECT 7 FROM Users WHERE CAST(DECRYPTBYKEY(Tai_Khoan) AS NVARCHAR(50)) = @Username)
	BEGIN
		PRINT N'---- Thông báo lỗi: Tài khoản đã tồn tại! ----'
		SET @ketQuaTraVe = 0
		RETURN 
	END
	SET @ketQuaTraVe = 1
	CLOSE SYMMETRIC KEY KeyUser
END

--[Thêm users]
CREATE OR ALTER PROCEDURE sp_Insert_Users (@Username NVARCHAR(50), @Password NVARCHAR(50), @ketQuaTraVe BIT OUT)
AS
BEGIN
	SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
	BEGIN TRANSACTION
		DECLARE @noti BIT
		EXEC sp_CheckUsers @Username, @Password, @noti OUT
		IF @noti = 1
		BEGIN
			PRINT N'---- TÀI KHOẢN HỢP LỆ! ----'
		END
		ELSE
		BEGIN
			PRINT N'---- TÀI KHOẢN KHÔNG HỢP LỆ! ----'
			SET @ketQuaTraVe = 0
			RETURN
		END

		DECLARE @UsernameEncryt VARBINARY(MAX), @PassEncryt VARBINARY(MAX)
		OPEN SYMMETRIC KEY KeyUser DECRYPTION BY CERTIFICATE CertUser
		SET @UsernameEncryt = ENCRYPTBYKEY(KEY_GUID('KeyUser'), CAST(@Username AS NVARCHAR(50)))
		SET @PassEncryt = ENCRYPTBYKEY(KEY_GUID('KeyUser'), CAST(@Password AS NVARCHAR(50)))
		CLOSE SYMMETRIC KEY KeyUser
		INSERT INTO Users (Tai_Khoan, Mat_Khau)
		VALUES (@UsernameEncryt, @PassEncryt)

		IF @@ROWCOUNT > 0
		BEGIN
			PRINT N'---- Thông báo kết quả: Thêm tài khoản thành công! ----'
			SET @ketQuaTraVe = 1
			COMMIT TRANSACTION
		END
		ELSE
		BEGIN
			PRINT N'---- Thông báo kết quả: Thêm tài khoản không thành công! ----'
			SET @ketQuaTraVe = 0
			ROLLBACK TRANSACTION
		END
END
