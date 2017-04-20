
# react-native-live-camera-recorder

## Getting started

`$ npm install react-native-live-camera-recorder --save`

### Mostly automatic installation

`$ react-native link react-native-live-camera-recorder`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-live-camera-recorder` and add `RNLiveCameraRecorder.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNLiveCameraRecorder.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNLiveCameraRecorderPackage;` to the imports at the top of the file
  - Add `new RNLiveCameraRecorderPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-live-camera-recorder'
  	project(':react-native-live-camera-recorder').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-live-camera-recorder/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-live-camera-recorder')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNLiveCameraRecorder.sln` in `node_modules/react-native-live-camera-recorder/windows/RNLiveCameraRecorder.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Com.Reactlibrary.RNLiveCameraRecorder;` to the usings at the top of the file
  - Add `new RNLiveCameraRecorderPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNLiveCameraRecorder from 'react-native-live-camera-recorder';

// TODO: What to do with the module?
RNLiveCameraRecorder;
```
  