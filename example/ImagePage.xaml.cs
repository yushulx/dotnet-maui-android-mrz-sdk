#if ANDROID
using Com.Dynamsoft.Dlr;
using Com.Dynamsoft.Dlr.Mrz;
#endif

namespace MauiAndroidMrz;

public partial class ImagePage : ContentPage
{
#if ANDROID
    MRZRecognizer recognizer;
#endif

    public ImagePage(string imagepath)
    {
        InitializeComponent();

        Image.Source = imagepath;

#if ANDROID
        recognizer = new MRZRecognizer();
        MRZResult? mrsResult = recognizer.RecognizeMRZFromFile(imagepath);
        if (mrsResult != null)
        {
            string mrzInfo = "";
            mrzInfo += "DocId: " + mrsResult.DocId + '\n';
            mrzInfo += "DocType: " + mrsResult.DocType + '\n';
            mrzInfo += "Nationality: " + mrsResult.Nationality + '\n';
            mrzInfo += "Issuer: " + mrsResult.Issuer + '\n';
            mrzInfo += "Birth: " + mrsResult.DateOfBirth + '\n';
            mrzInfo += "Expiration: " + mrsResult.DateOfExpiration + '\n';
            mrzInfo += "Gender: " + mrsResult.Gender + '\n';
            mrzInfo += "Surname: " + mrsResult.Surname + '\n';
            mrzInfo += "GivenName: " + mrsResult.GivenName + '\n';
            mrzInfo += "IsParsed: " + mrsResult.IsParsed + '\n';
            mrzInfo += "IsVerified: " + mrsResult.IsVerified + '\n';

            Result.Text = mrzInfo;
        }
#endif

    }
}