# FocusPC Window Embedding Application

The FocusControl Software Development Kit (SDK) is designed for the integration of FocusPC in custom software environments. FocusControl is mainly used for the development of application-dedicated software interface and system automation.

Compatible Programming Languages (32-bit 64-bit)

- C++
- C#
- VB
- LabVIEW

The most common types of applications can be narrowed down to the following three categories:

- **FocusPC integration applications**

  Used for remotely controlling the FocusPC Software, which in turn is used to control the inspection sequence and data processing functionalities.

- **Online data applications**

  Used for extracting data and monitoring FocusPC in deferred real time, in order to create a pseudo-live data display application.

- **FocusPC window embedding applications**

  Used for integrating FocusPC components inside an external program to create a customized application with FocusPC operating in the background.

The purpose of this project is to provide an example of ***FocusPC window embedding applications***.

#### Installation

1. Go to software download page: https://www.olympus-ims.com/en/service-and-support/downloads/
2. Expand ***FocusPC & SDK*** and download ***FocusControl 32bit*** or ***FocusControl 64bit***
3. Double-click .exe file and follow the instruction to install the software.

#### Security Information

HASP USB key must be activated for FocusControl (1.0).

If no HASP key is detected, an error would prompt.

![](https://github.com/ospqul/FocuxPCEmbeddingDemo/blob/master/resources/NoHASPKey.PNG)

If software is installed correctly, a "KeyTool" software is also installed. You could use "KeyTool" to check the if FocusControl is activated.

![](https://github.com/ospqul/FocuxPCEmbeddingDemo/blob/master/resources/keytool.PNG)

#### Add Reference

- Add `AxInterop.FocusPCActiveXLib.dll` and `Interop.FocusPCActiveXLib.dll` as reference, and copy `Interop.FocusPCActiveXLib.dll` next to exe file. If software is installed in default path, you could find them in: `C:\Program Files\Olympus NDT\FocusControl 1.0\Samples\x64\Binaries`

- Add a reference to the WindowsFormsIntegration assembly, which is named WindowsFormsIntegration.dll. We need to use `WindowsFormsHost` to host ActiveX Control.
- Add a reference to the Windows Forms assembly, which is named System.Windows.Forms.dll.

#### FocusPCActiveX Object Members

FocusPCActiveX is Olympus NDT FocusPC ActiveX Control, it has two public methods:

- HookFocusPC
- UnhookFocusPC

![](https://github.com/ospqul/FocuxPCEmbeddingDemo/blob/master/resources/UI.PNG)

![](https://github.com/ospqul/FocuxPCEmbeddingDemo/blob/master/resources/SelectDevice.PNG)

![](https://github.com/ospqul/FocuxPCEmbeddingDemo/blob/master/resources/Embedded.PNG)
