using System.Threading.Tasks;

namespace Caliburn.Features.Helper
{
    /// <summary>
    /// Task Helper class to manage differences in the Task libraries between versions
    /// </summary>
    public static class TaskHelper
    {
        public static Task<T> FromResult<T>(T result) => Task.FromResult(result);

        public static Task Delay(int milliseconds) => Task.Delay(milliseconds);
    }
}
