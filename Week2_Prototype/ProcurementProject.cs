
public class ProcurementProject
{
    public string ProjectName { get; }
    public string Department { get; }

    public decimal AllocatedBudget { get; private set; }
    public bool IsAudited { get; private set; }

    public ProcurementProject(
        string projectName,
        string department,
        decimal allocatedBudget)
    {
        ProjectName = projectName;
        Department = department;
        AllocatedBudget = allocatedBudget;
        IsAudited = false;
    }

    public bool UpdateBudget(decimal newBudget)
    {
        if (IsAudited || newBudget <= 0)
        {
            return false;
        }

        AllocatedBudget = newBudget;
        return true;
    }

    public bool CompleteAudit()
    {
        if (IsAudited || AllocatedBudget <= 0)
        {
            return false;
        }

        IsAudited = true;
        return true;
    }
}
