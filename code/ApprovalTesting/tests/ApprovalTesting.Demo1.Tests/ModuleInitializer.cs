using System.Runtime.CompilerServices;
using DiffEngine;

namespace ApprovalTesting.Demo1.Tests;

public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize() =>
        // For details, see: https://github.com/VerifyTests/DiffEngine/blob/main/docs/diff-tool.order.md#via-code
        DiffTools.UseOrder(DiffTool.Rider);
}