using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang
{
    public class AuthenticationService
    {
        private static AuthenticationService _instance;
        private static readonly object _lock = new object();

        // Singleton pattern
        public static AuthenticationService Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new AuthenticationService();
                    }
                }
                return _instance;
            }
        }

        // User hiện tại đã đăng nhập
        public NhanVien CurrentUser { get; private set; }

        // Danh sách user mẫu (trong thực tế sẽ lấy từ database)
        private List<NhanVien> _users = new List<NhanVien>
        {
            new NhanVien(1, "Admin System", "admin", "admin123", UserRole.Admin),
            new NhanVien(2, "Anh Khoa", "khoa", "123456", UserRole.Admin),
            new NhanVien(3, "Quan Thùy Trâm", "tram", "123456", UserRole.NhanVien),
            new NhanVien(4, "Nhân viên 1", "nv1", "123456", UserRole.NhanVien),
            new NhanVien(5, "Nhân viên 2", "nv2", "123456", UserRole.NhanVien)
        };

        private AuthenticationService() { }

        /// <summary>
        /// Đăng nhập user
        /// </summary>
        /// <param name="username">Tên đăng nhập</param>
        /// <param name="password">Mật khẩu</param>
        /// <returns>User nếu đăng nhập thành công, null nếu thất bại</returns>
        public NhanVien Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return null;

            var user = _users.FirstOrDefault(u => 
                u.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) && 
                u.Password == password);

            if (user != null)
            {
                CurrentUser = user;
            }

            return user;
        }

        /// <summary>
        /// Đăng xuất user hiện tại
        /// </summary>
        public void Logout()
        {
            CurrentUser = null;
        }

        /// <summary>
        /// Kiểm tra user có quyền admin không
        /// </summary>
        /// <returns>True nếu là admin</returns>
        public bool IsCurrentUserAdmin()
        {
            return CurrentUser != null && CurrentUser.IsAdmin();
        }

        /// <summary>
        /// Kiểm tra user có quyền truy cập chức năng không
        /// </summary>
        /// <param name="requiredRole">Quyền yêu cầu</param>
        /// <returns>True nếu có quyền</returns>
        public bool HasPermission(UserRole requiredRole)
        {
            if (CurrentUser == null)
                return false;

            // Admin có tất cả quyền
            if (CurrentUser.Role == UserRole.Admin)
                return true;

            // Kiểm tra quyền cụ thể
            return CurrentUser.Role == requiredRole;
        }

        /// <summary>
        /// Lấy danh sách tất cả user (chỉ admin)
        /// </summary>
        /// <returns>Danh sách user hoặc null nếu không có quyền</returns>
        public List<NhanVien> GetAllUsers()
        {
            if (!IsCurrentUserAdmin())
                return null;

            return new List<NhanVien>(_users);
        }

        /// <summary>
        /// Thêm user mới (chỉ admin)
        /// </summary>
        /// <param name="user">User mới</param>
        /// <returns>True nếu thành công</returns>
        public bool AddUser(NhanVien user)
        {
            if (!IsCurrentUserAdmin() || user == null)
                return false;

            // Kiểm tra username đã tồn tại chưa
            if (_users.Any(u => u.UserName.Equals(user.UserName, StringComparison.OrdinalIgnoreCase)))
                return false;

            // Tạo ID mới
            user.MaNV = _users.Count > 0 ? _users.Max(u => u.MaNV) + 1 : 1;
            _users.Add(user);
            return true;
        }

        /// <summary>
        /// Xóa user (chỉ admin và không thể xóa chính mình)
        /// </summary>
        /// <param name="userId">ID user cần xóa</param>
        /// <returns>True nếu thành công</returns>
        public bool DeleteUser(int userId)
        {
            if (!IsCurrentUserAdmin())
                return false;

            // Không thể xóa chính mình
            if (CurrentUser.MaNV == userId)
                return false;

            var user = _users.FirstOrDefault(u => u.MaNV == userId);
            if (user != null)
            {
                _users.Remove(user);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Cập nhật thông tin user (admin có thể sửa tất cả, user chỉ sửa được của mình)
        /// </summary>
        /// <param name="updatedUser">Thông tin user đã cập nhật</param>
        /// <returns>True nếu thành công</returns>
        public bool UpdateUser(NhanVien updatedUser)
        {
            if (CurrentUser == null || updatedUser == null)
                return false;

            // Chỉ admin hoặc chính user đó mới được sửa
            if (!IsCurrentUserAdmin() && CurrentUser.MaNV != updatedUser.MaNV)
                return false;

            var existingUser = _users.FirstOrDefault(u => u.MaNV == updatedUser.MaNV);
            if (existingUser != null)
            {
                existingUser.TenNV = updatedUser.TenNV;
                existingUser.Password = updatedUser.Password;
                
                // Chỉ admin mới được thay đổi role
                if (IsCurrentUserAdmin())
                    existingUser.Role = updatedUser.Role;

                return true;
            }
            return false;
        }
    }
}