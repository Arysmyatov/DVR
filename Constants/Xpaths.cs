namespace DVR.Constants
{
    public static class Xpaths
    {
        public const string VacancyUrl = @"//*[@id='vacancyListId']/ul/li/div/div/a";
        public const string CompanyName = @"//*[@class='b-compinfo']/div/div[1]/a[1]";
        public const string CompanyDescription = @"//*[@class='b-compinfo']/div/div[2]";
        public const string Position = @"//*[@class='b-vacancy']/h1";
        public const string Vacancy = @"//*[@class='l-vacancy']";
        public const string AboutProject = @"//*[@class='project']/*/p";        
    }
}   