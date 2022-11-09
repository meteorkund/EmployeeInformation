using System.Threading;

namespace EmployeeInformation.WPF.HostBuilders;

public class AppControl
{
    static Mutex mtx = null;
    public static bool IsAppRunning(string AppName)
    {
        Mutex.TryOpenExisting(AppName, out mtx);
        if (mtx == null)
        {
            mtx = new Mutex(true, AppName);
            return true;
        }
        else
        {
            mtx.Close();
            return false;
        }
    }
}
