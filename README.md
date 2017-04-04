# Mobile Center - Quickstart for Xamarin.Forms

This sample app will help you onboard to Mobile Center Build, Analytics and Crashes services within few minutes.

## Steps:
1.  Create an app in Mobile Center portal - Login to the [portal](https://mobile.azure.com) and create an iOS and Android app.
2.  Fork this repo – Fork this repo and create a copy of your own to experiment with the app. It will help onboarding to our Build service in case you don’t have an app repo in GitHub. Your next steps are to go to the Build service in the portal, select the Android app that you just created, set up the master branch and build configuration to build every time a commit happens. 
3.  Download the repo - This repo contains a basic Xamarin.Forms app setup to play with. Once you download, you should easily be able to run the app in Visual Studio. 
4.  Edit the app secrets - Once the repo is downloaded, open App.xaml.cs file and edit {IOS_APP_SECRET} and {ANDROID_APP_SECRET} placeholders text with actual app secrets. You can get the value from Getting started page of this app from the portal.
5.  Run - Once the app is modified, run the app in the simulator. Click on the Crash Me button and open the app again.
6.  You should now be able to see the Analytics and Crashes data in the portal and build this application on every commit.