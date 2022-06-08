namespace FileSystemResolver;

public static class FileSystemResolver
{
    public static int Resolve(IReadOnlyList<string> ops)
    {
        int depth = 0;
        foreach (var operation in ops)
        {
            if (operation.StartsWith(".."))
            {
                if (depth > 0)
                    depth--;
            }
            else if (operation.StartsWith("."))
            {
            }
            else
                depth++;
        }

        return depth;
    }
}