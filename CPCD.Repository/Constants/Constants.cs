using System.Collections.Generic;

namespace CPCD.Repository.Constants;

public static class Constants
{
    public static class FILE
    {
        public static List<string> UNSUPPORTED_FORMATS = new() { "exe", "cmd", "bat", "run", "ini" };

        public const long MAX_IMAGE_SIZE_KB = 120000;
        public const int MINIMUM_IMAGE_PIXEL = 840;

        public static class IMAGE_FILE
        {
            public const string JPEG = "image/jpeg";
            public const string JPG = "image/jpg";
            public const string PNG = "image/png";
            public const string WEBP = "image/webp";
            public const string BMP = "image/bmp";

            public const string GIF = "image/gif";
            public const string TIFF = "image/tiff";
            public const string PBM = "image/x-portable-bitmap";
            public const string TGA = "image/tga";

            public const string PPM = "image/x-portable-pixmap";
            public const string RGB = "image/x-rgb";
            public const string ICO = "image/x-icon";
            public const string SVG = "image/svg+xml";
        }
    }

    public static class UserRoles
    {
        public static class ADMIN
        {
            public const long Id = 1;
            public const string Name = "ADMIN";
        }

        public static class COACH
        {
            public const long Id = 2;
            public const string Name = "COACH";
        }

        public static class CONTESTANT
        {
            public const long Id = 3;
            public const string Name = "CONTESTANT";
        }

        public static long GetRole(string roleName) => roleName switch
        {
            ADMIN.Name => ADMIN.Id,
            COACH.Name => COACH.Id,
            CONTESTANT.Name => CONTESTANT.Id,
            _ => -1,
        };

        public static string GetRoleById(long roleId) => roleId switch
        {
            ADMIN.Id => ADMIN.Name,
            COACH.Id => COACH.Name,
            CONTESTANT.Id => CONTESTANT.Name,
            _ => "None",
        };
    }
}