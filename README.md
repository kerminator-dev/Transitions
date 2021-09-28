# Transitions
## Overview 

Class library for creating transitions with an example of usage on Windows Forms. Library allows to create smooth transitions/animations for your controls.

![alt text](https://github.com/kerminator-dev/Transitions/blob/main/Images/preview2.gif?raw=true)


## Class Library

Class Library with easing functions:
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

## Usage

Connecting namespaces:

![alt text](https://github.com/kerminator-dev/Transitions/blob/main/Images/code-example-3.png?raw=true)

An example of creating and running a transition:

![alt text](https://github.com/kerminator-dev/Transitions/blob/main/Images/code-example-1.JPG?raw=true)

#### Required parameters: 
- startValue      (int) - start transition value in pixels (example: -10);
- endValue        (int) - target transition value in pixels (example - endValue: 100);
- duration        (int) - transition time in milliseconds. duration > 0;
- onValueChanged  (Action)- callback action, used to update view (example - onValueChanged: OnValueChangedCallBack);
- easingFunction  (EasingFunction) - TransitionsLibrary.Models.Functions.Easings function used to transition (example - easingFunction: Easings.Back.InOut);
- targetControl   (Control) - the control that requires a transition (example - targetControl: panel1). The specified control will be available in the callback method as Control control object.

##### Optional parameters:
- fps:            (int) - frames per second. Default value: 40;
- startDelay:     (int) - Thread sleep delay in milliseconds before transition start. Default value: 0.

The elements in the callback method must be accessed via the user interface thread! Example of a callback method:

![alt text](https://github.com/kerminator-dev/Transitions/blob/main/Images/code-example-2.JPG?raw=true)

## Examples

### [Usage example 1 - horizontal transition of the control by MouseDown event](https://github.com/kerminator-dev/Transitions/tree/main/TransitionsTest)
### [Usage example 2 - horizontal transition of the cards and pop-up notifications](https://github.com/kerminator-dev/Transitions/tree/main/TransitionsTest)

## Nuances of usage

- The main nuance is the inability of Windows Forms technology to quickly render controls, which is noticeable when using the library. At a high frame rate, the elements do not have time to be drawn.
- Transition processing is based on CPU only! For a better experience, the transitions should be handled by the GPU.
- You cannot work with controls through another thread
