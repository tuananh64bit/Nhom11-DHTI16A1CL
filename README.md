<h1 align="center">📝 HỆ THỐNG ÔN TẬP TRẮC NGHIỆM</h1>
<p align="center">
  <i>Xây dựng ứng dụng web hỗ trợ ôn tập và làm bài thi trắc nghiệm trực tuyến</i><br>
  <strong>Ngôn ngữ:</strong> C# (.NET), HTML/CSS, JavaScript<br>
</p>

---

## 👥 Thành viên nhóm

| STT | Họ và tên          | Vai trò              |
|-----|--------------------|----------------------|
| 1   | Phùng Tuấn Anh     | Backend |
| 2   | Vũ Việt Anh        | lắc đít             |
| 3   | Vũ Văn Nam         | Cơ sở dữ liệu        |
| 4   | Giang Minh Quân    | Test, UI/UX          |

---

## 📌 Mô tả dự án

Hệ thống ôn tập trắc nghiệm là ứng dụng cho phép:

- 👤 Người dùng đăng ký, đăng nhập để làm bài thi.
- 📝 Quản trị viên tạo đề thi, thêm/sửa câu hỏi.
- ⏱️ Thi trực tuyến theo thời gian quy định.
- 📊 Xem kết quả, thống kê, lịch sử thi.
- 🔍 Ôn luyện theo chủ đề, tự chọn số câu.

---

## ⚙️ Công nghệ sử dụng

| Thành phần        | Công nghệ                |
|-------------------|--------------------------|
| 🧠 Ngôn ngữ        | C#, .NET Framework, Winform |
| 🗄️ Cơ sở dữ liệu   | SQL Server              |
| 🎨 Giao diện       | HTML, CSS, Bootstrap    |
| ⚙️ Công cụ         | Visual Studio, SSMS     |
| 🔐 Xác thực        | ASP.NET Identity         |

---

## 🖼️ Giao diện minh họa

<p align="center">
  <img src="screenshots/login.png" width="45%" alt="Login">
  <img src="screenshots/dashboard.png" width="45%" alt="Dashboard">
</p>

---

## 🛠️ Hướng dẫn cài đặt

### ✅ Yêu cầu

- .NET SDK (.NET 6 hoặc 7)
- Visual Studio 2022+
- SQL Server / LocalDB

### 🚀 Cách chạy

```bash
# Clone project
git clone https://github.com/username/quiz-app.git
cd quiz-app

# Mở file solution (.sln) bằng Visual Studio

# Khởi tạo cơ sở dữ liệu nếu chưa có
Update-Database

# Chạy ứng dụng
F5 hoặc nhấn nút Run
