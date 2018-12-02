using System;

namespace DailyChallenge.bitwise
{
    public class PermissionHandler
    {

        public bool CanExecute(int userPermission) {
            var got = (Permission)userPermission;
            return got.HasFlag(Permission.Execute);
        }

        public bool CanRead(int userPermission) {
            var got = (Permission)userPermission;
            return got.HasFlag(Permission.Read);
        }

        public bool CanWrite(int userPermission) {
            var got = (Permission)userPermission;
            return got.HasFlag(Permission.Write);
        }

    }

    [Flags]
    public enum Permission
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4,

    }

}
