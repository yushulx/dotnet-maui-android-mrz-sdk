# Android MRZ SDK for .NET MAUI
This repository showcases the integration of an Android MRZ (Machine-Readable Zone) SDK into a .NET MAUI project. By using this SDK, you can easily add MRZ recognition capabilities to your .NET MAUI Android application.

![dotnet-maui-android-mrz-recognition](https://github.com/yushulx/dotnet-maui-android-mrz-sdk/assets/2202306/cb711e52-9e66-4153-804d-8118f67fef64)

## Released NuGet Package
[https://www.nuget.org/packages/MrzSDK/](https://www.nuget.org/packages/MrzSDK/)

## Prerequisites
- Download [Dynamsoft Label Recognizer for Android](https://www.dynamsoft.com/label-recognition/downloads) and extract the `DynamsoftCore.aar` and `DynamsoftLabelRecognizer.aar` files from the zip file.
- `MRZLib.aar`: Get the source code of the Android MRZ SDK from [https://github.com/Dynamsoft/label-recognizer-mobile-samples/tree/master/android/MRZScanner/MRZLib](https://github.com/Dynamsoft/label-recognizer-mobile-samples/tree/master/android/MRZScanner/MRZLib). Then, build the Android AAR library in **Android Studio**.

## Android Library Binding for .NET MAUI
1. Import the Android library binding project from the `sdk` folder to **Visual Studio**.
2. Build and pack it into a NuGet package.



## Example
1. Open the example project from the `example` folder in **Visual Studio**.
2. Connect an Android device to your computer.
3. Build and run the project for the Android platform. 
