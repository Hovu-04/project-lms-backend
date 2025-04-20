# Learning Management System (LMS) Backend

## Giới thiệu
Hệ thống Quản lý Học tập (LMS) là một ứng dụng backend được xây dựng bằng ASP.NET Core, cung cấp các API để quản lý toàn diện các hoạt động học tập và giảng dạy.

## Tính năng chính
- **Quản lý người dùng**
  - Học sinh/Sinh viên
  - Giáo viên
  - Quản trị viên
  - Phân quyền và xác thực

- **Quản lý học tập**
  - Khóa học và lớp học
  - Bài giảng và tài liệu
  - Bài tập và kiểm tra
  - Chấm điểm và đánh giá
  - Lớp học trực tuyến

- **Quản lý trường học**
  - Năm học và học kỳ
  - Khoa/Phòng ban
  - Chi nhánh trường
  - Môn học và nhóm môn học

- **Tính năng khác**
  - Thông báo
  - Chat và trao đổi
  - Báo cáo và thống kê
  - Hỗ trợ trực tuyến

## Công nghệ sử dụng
- ASP.NET Core
- Entity Framework Core
- SQL Server
- JWT Authentication
- SignalR (cho chat và thông báo real-time)
- Cloudinary (quản lý file và media)
- Twilio (tích hợp SMS)

## Yêu cầu hệ thống
- .NET 6.0 SDK trở lên
- Postgresql
- Visual Studio 2022 (khuyến nghị) hoặc VS Code

## Cài đặt và Chạy
1. Clone repository:
```bash
git clone [repository-url]
```

2. Cấu hình connection string và các biến môi trường:
- Tạo file `.env` từ `.env.example`
- Cập nhật các giá trị cấu hình phù hợp

3. Chạy migration để tạo database:
```bash
dotnet ef database update
```

4. Build và chạy project:
```bash
dotnet build
dotnet run
```

## Cấu trúc Project
- `Controllers/`: Chứa các API endpoints
- `Models/`: Định nghĩa các entity
- `DTOs/`: Data Transfer Objects
- `Services/`: Business logic
- `Repositories/`: Data access layer
- `Interfaces/`: Các interface định nghĩa contracts
- `Helpers/`: Các utility functions
- `Middleware/`: Custom middleware
- `Authorization/`: Xử lý phân quyền

## API Documentation
API documentation có thể được truy cập tại `/swagger` sau khi chạy project.

## Đóng góp
Mọi đóng góp đều được hoan nghênh. Vui lòng:
1. Fork project
2. Tạo feature branch
3. Commit changes
4. Push to branch
5. Tạo Pull Request

