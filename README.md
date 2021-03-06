# Transitions
## Overview 

Class library for creating transitions with an example of usage on Windows Forms. Library allows to create smooth transitions/animations for your components.

![alt text](https://github.com/kerminator-dev/Transitions/blob/main/Images/preview2.gif?raw=true)

## Class Library
[The library](https://github.com/kerminator-dev/Transitions/blob/main/TransitionsLibrary/bin/Debug/TransitionsLibrary.dll) contains following easing functions:
- Linear
- Quadratic (in, out, in/out, bezier)
- Cubic (in, out, in/out)
- Quartic (in, out, in/out)
- Quintic (in, out, in/out)
- Sinusoidal (in, out, in/out)
- Exponential (in, out, in/out)
- Circular (in, out, in/out)
- Elastic (in, out, in/out)
- Back (in, out, in/out)
- Bounce (in, out, in/out)

You can also see examples of transitions [here](https://easings.net/). Anyway, you can add a custom function via the EasingFunction delegate. All transitions run in a separate thread

## Usage

### Simple usage [code example](https://github.com/kerminator-dev/Transitions/blob/main/Examples/SimpleConsoleExample/Program.cs)

#### 1. Connecting namespaces:

![alt text](https://github.com/kerminator-dev/Transitions/blob/main/Images/code-example-3.png?raw=true)

#### 2. An example of creating and running a transition:

![alt text](https://github.com/kerminator-dev/Transitions/blob/main/Images/code-example-1.JPG?raw=true)

#### Required parameters: 
- startValue      (int) - start transition value in pixels (example: -10);
- endValue        (int) - target transition value in pixels (example - endValue: 100);
- duration        (int) - transition time in milliseconds. duration > 0;
- onValueChanged  (Action)- callback action, used to update view (example - onValueChanged: OnValueChangedCallBack);
- easingFunction  (EasingFunction) - TransitionsLibrary.Models.Functions.Easings function used to transition (example - easingFunction: Easings.Back.InOut);
- targetControl   (Control) - the control that requires a transition (example - targetControl: panel1). The specified control will be available in the callback method as Control control object.

#### Optional parameters:
- fps:            (int) - frames per second. Default value: 40. fps > 0;
- startDelay:     (int) - Thread sleep delay in milliseconds before transition start. Default value: 0. startDelay > 0.

#### 3. The elements in the callback method must be accessed via the user interface thread! Example of a callback method:

![alt text](https://github.com/kerminator-dev/Transitions/blob/main/Images/code-example-2.JPG?raw=true)

### Extended usage example with Transition Manager

Transition Manager allows you to work with multiple animations simultaneously in multiple threads. 
Extended usage example with Transition Manager you can see [here](https://github.com/kerminator-dev/Transitions/tree/main/NotificationsTest)

## Examples

### [Usage example 1 - simple example in console application](https://github.com/kerminator-dev/Transitions/tree/main/Examples/SimpleConsoleExample)

![alt ext](https://github.com/kerminator-dev/Transitions/blob/main/Images/preview3.gif?raw=true)

### [Usage example 2 - horizontal transition of the control by MouseDown event](https://github.com/kerminator-dev/Transitions/tree/main/Examples/TransitionsTest)

![alt text](https://github.com/kerminator-dev/Transitions/blob/main/Images/preview.gif?raw=true)

### [Usage example 3 - horizontal transition of the cards and pop-up notifications](https://github.com/kerminator-dev/Transitions/tree/main/Examples/NotificationsTest)

![alt text](https://github.com/kerminator-dev/Transitions/blob/main/Images/preview2.gif?raw=true)

### [Usage example 4 - color transition](https://github.com/kerminator-dev/Transitions/tree/main/Examples/ColorTransitionExample)

![alt text](https://github.com/kerminator-dev/Transitions/blob/main/Images/preview4.gif?raw=true)

## Nuances of usage

- The main nuance is the inability of Windows Forms technology to quickly render controls, which is noticeable when using the library. At a high frame rate, the elements do not have time to be drawn.
- Transition processing is based on CPU only! For a better experience, the transitions should be handled by the GPU.
- You cannot work with controls through another thread. Use InvokeRequired property and Invoke method to access control properties.