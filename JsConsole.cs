using Microsoft.JSInterop;

namespace JsConsole
{
    public static class JsConsole
    {
        public static void Assert (IJSRuntime js, bool condition, string message) =>
            JSRuntimeExtensions.InvokeVoidAsync(js, "console.assert", new object[] { condition, message });

        public static void Clear (IJSRuntime js) =>
            JSRuntimeExtensions.InvokeVoidAsync(js, "console.clear");

        public static void Count (IJSRuntime js, string label = "") =>
            JSRuntimeExtensions.InvokeVoidAsync(js, "console.count", label ?? null);

        public static void Error (IJSRuntime js, string message) =>
            JSRuntimeExtensions.InvokeVoidAsync(js, "console.error", message);

        public static void Group (IJSRuntime js) =>
            JSRuntimeExtensions.InvokeVoidAsync(js, "console.group");

        public static void GroupCollapsed (IJSRuntime js) =>
            JSRuntimeExtensions.InvokeVoidAsync(js, "console.groupCollapsed");

        public static void GroupEnd (IJSRuntime js) =>
            JSRuntimeExtensions.InvokeVoidAsync(js, "console.groupEnd");

        public static void Info (IJSRuntime js, string message) =>
            JSRuntimeExtensions.InvokeVoidAsync(js, "console.info", message);

        public static void Log (IJSRuntime js, string message) =>
            JSRuntimeExtensions.InvokeVoidAsync(js, "console.log", message);

        public static void Table (IJSRuntime js, object data) =>
            JSRuntimeExtensions.InvokeVoidAsync(js, "console.table", data);

        public static void Time (IJSRuntime js) =>
            JSRuntimeExtensions.InvokeVoidAsync(js, "console.time");

        public static void TimeEnd (IJSRuntime js) =>
            JSRuntimeExtensions.InvokeVoidAsync(js, "console.timeEnd");

        public static void Trace (IJSRuntime js) =>
            JSRuntimeExtensions.InvokeVoidAsync(js, "console.trace");

        public static void Warn (IJSRuntime js, string message) =>
            JSRuntimeExtensions.InvokeVoidAsync(js, "console.warn", message);
    }
}
