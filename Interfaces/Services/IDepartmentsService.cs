using Project_LMS.DTOs.Request;
using Project_LMS.DTOs.Response;

namespace Project_LMS.Interfaces
{
    public interface IDepartmentsService
    {
        Task<ApiResponse<PaginatedResponse<DepartmentResponse>>> GetAllCoursesAsync(
            int? pageNumber,
            int? pageSize,
            string? sortDirection
        );

        Task<ApiResponse<DepartmentResponse>> CreateDepartmentAsync(CreateDepartmentRequest createDepartmentRequest);

        Task<ApiResponse<DepartmentResponse>> UpdateDepartmentAsync(UpdateDepartmentRequest updateDepartmentRequest);

        Task<ApiResponse<DepartmentResponse>> DeleteDepartmentAsync(string id);

        Task<ApiResponse<PaginatedResponse<DepartmentResponse>>> SearchDepartmentsAsync(string? keyword,
            int? pageNumber,
            int? pageSize,
            string? sortDirection);

        Task<ApiResponse<IEnumerable<object>>> GetAllClassesAsync(int departmentId);
        Task<ApiResponse<string>> DeleteClassById(List<int> classId);
        Task<List<DepartmentDropdownResponse>> GetDepartmentDropdownAsync();
        Task<ApiResponse<DepartmentResponse>> GetDepartmentById(int departmentId);
        Task<ApiResponse<IEnumerable<object>>> ListUserDepartment();
    }
}