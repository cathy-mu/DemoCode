using System;
using System.Collections.Generic;

namespace CodeDemo.Library.Biz
{
    public static class PatternMatchingBiz
    {
        public static bool IsLetter(this char c) =>
        c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

        public static bool IsLetterOrSeparator(this char c) =>
        c is >= 'a' and <= 'z' or >= 'A' and <= 'Z' or '.' or ',';
        //c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';


        public static bool IsNull(this List<int> c) =>
        c is null;

        public static bool IsNotNull(this List<int> c) =>
        c is not null;

        public static bool IsNullOrBlankOrEmpty(this string s) =>
        s?.Trim() is not { Length: > 0 };

        public static bool IsNotNullOrBlankOrEmpty(this string s) =>
        s?.Trim() is { Length: > 0 };

        public static bool IsDoubleOrDecimalOrFloat(object o) =>
        o is double or decimal or float;
        public static bool IsNotDoubleOrDecimalOrFloat(object o) =>
        o is not double or decimal or float;

        public static String GetNameById(SE s) => s.Id switch
        {
            1 or 392 => "Baidu",
            < 17 and < 30 => "Google Desktop",
            > 400 => "Google UULE",
            _ => "Unknow"
        };

        public static int GetMinAge(Person p) => p switch
        {
            Teacher => 25, // Teacher t _ => 25 before C# 9
            Student => 6, // Student s _ => 6 before C# 9
            _ => 30
        };

        public static String GetEducationName(Student p) => p.Level switch
        {
            <= 6  => "Pre-Primary",
            > 6 and <12 => "Primary School",
            > 12 and <18 => "High School",  
            _ => "University"
        };


    }



}
