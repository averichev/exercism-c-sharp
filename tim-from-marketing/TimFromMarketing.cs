using System.Text;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var builder = new StringBuilder();
        if (id != null)
        {
            builder.Append($"[{id}] - ");
        }

        builder.Append(name);
        if (department != null)
        {
            builder.Append($" - {department.ToUpper()}");
        }
        else
        {
            builder.Append(" - OWNER");
        }

        var result = builder.ToString();
        return result;
    }
}
