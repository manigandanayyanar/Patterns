using FactoryPattern.interfaces;
using FactoryPattern;
using BuilderPattern.BuilderClass;
using BuilderPattern.Interfaces;
using BuilderPattern;

namespace Patterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            //FactoryPattern();
            //BuilderPatter();
            //Singleton.GetSingletonInstance();
            //Singleton.ThreadSafe();
            //FACADE.PlaceOrderFacade();
            FACADE.BankingFacade();
        }

        #region FactoryPattern
        static void FactoryPattern()
        {
            string provider = "AWS"; // Or CloudProvider.Azure, CloudProvider.GCP based on user selection
            FileUploaderFactory fileUploaderFactory = new();
            IFileUploader fileUploader = fileUploaderFactory.CreateFileUploader(provider);

            string filePath = "path/to/your/file.txt";
            fileUploader.UploadFile(filePath);
        }
        #endregion

        #region BuilderPattern
        static void BuilderPatter()
        {
            // Construct a basic user profile
            IUserProfileBuilder basicUserProfileBuilder = new BasicUserProfileBuilder();
            UserProfileBuilder director = new UserProfileBuilder(basicUserProfileBuilder);
            UserProfile basicUserProfile = director.ConstructUserProfile(
                "basicUser",
                "basic@example.com",
                null,
                null,
                "This is a basic user."
            );
            Console.WriteLine(basicUserProfile);

            // Construct a premium user profile
            IUserProfileBuilder premiumUserProfileBuilder = new PremiumUserProfileBuilder();
            director = new UserProfileBuilder(premiumUserProfileBuilder);
            UserProfile premiumUserProfile = director.ConstructUserProfile(
                "premiumUser",
                "premium@example.com",
                "123 Premium St.",
                "123-456-7890",
                "This is a premium user with all details."
            );
            Console.WriteLine(premiumUserProfile);
        } 
        #endregion
    }
}