@model EmployeeManagement.Models.Employee

@{
    ViewData["Title"] = "Create Employee";
}

<div class="container mt-4">
    <div class="card shadow-lg p-4">
        <h2 class="text-center text-primary mb-4">Create Employee</h2>

        <form asp-action="Create">
            <div asp-validation-summary="All" class="text-danger mb-3"></div>

            <div class="mb-3">
                <label asp-for="Name" class="form-label"></label>
                <input asp-for="Name" class="form-control" placeholder="Enter name" />
                <span asp-validation-for="Name" class="text-danger"></span>
            </div>

            <div class="mb-3">
                <label asp-for="Email" class="form-label"></label>
                <input asp-for="Email" class="form-control" placeholder="Enter email" />
                <span asp-validation-for="Email" class="text-danger"></span>
            </div>

            <div class="mb-3">
                <label asp-for="Salary" class="form-label"></label>
                <input asp-for="Salary" class="form-control" placeholder="Enter salary" />
                <span asp-validation-for="Salary" class="text-danger"></span>
            </div>

            <div class="mb-3">
                <label class="form-label">Department</label>
                <select asp-for="DepartmentId" class="form-select" asp-items="ViewBag.DepartmentId">
                    <option value="">-- Select Department --</option>
                </select>
                <span asp-validation-for="DepartmentId" class="text-danger"></span>
            </div>

            <div class="d-flex justify-content-between">
                <a asp-action="Index" class="btn btn-secondary">Back</a>
                <button type="submit" class="btn btn-success">Save</button>
            </div>
        </form>
    </div>
</div>

@section Scripts {
    <partial name="_ValidationScriptsPartial" />
}
