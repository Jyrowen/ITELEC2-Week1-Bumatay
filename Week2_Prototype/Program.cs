
var project1 = new ProcurementProject(
    "Manila City Hall Solar Infrastructure",
    "Department of Engineering",
    5000000m
);

var project2 = new ProcurementProject(
    "District 3 Health Center Medical Supplies",
    "Department of Health",
    1500000m
);

Console.WriteLine("=== PROCUREMENT PROJECT TEST ===");

Console.WriteLine("\nPROJECT 1:");
Console.WriteLine("Project: " + project1.ProjectName);
Console.WriteLine("Department: " + project1.Department);

Console.WriteLine(
    "Complete Audit: " + project1.CompleteAudit()
);

Console.WriteLine(
    "Update Budget After Audit: " +
    project1.UpdateBudget(6000000m)
);

Console.WriteLine(
    "Audit Status: " + project1.IsAudited
);

Console.WriteLine("\nPROJECT 2:");
Console.WriteLine("Project: " + project2.ProjectName);
Console.WriteLine("Department: " + project2.Department);

Console.WriteLine(
    "Update Budget Before Audit: " +
    project2.UpdateBudget(2000000m)
);

Console.WriteLine(
    "New Budget: " + project2.AllocatedBudget
);

Console.WriteLine("\n=== TEST COMPLETE ===");
