# Transitions
## Overview 

Class library for creating transitions with an example of usage on Windows Forms. Library allows to create smooth transitions/animations for your controls.

![alt text](https://github.com/kerminator-dev/Transitions/blob/main/Images/preview.gif?raw=true)


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

Namespace connections:

![alt text](https://github.com/kerminator-dev/Transitions/blob/main/Images/code-example-3.png?raw=true)

An example of creating and running a transition:

![alt text](https://github.com/kerminator-dev/Transitions/blob/main/Images/code-example-1.JPG?raw=true)

The elements in the callback method must be accessed via the user interface thread! Example of a callback method:

![alt text](https://github.com/kerminator-dev/Transitions/blob/main/Images/code-example-2.JPG?raw=true)

## Nuances of usage

- The main nuance is the inability of Windows Forms technology to quickly render controls, which is noticeable when using the library. At a high frame rate, the elements do not have time to be drawn.
- Transition processing is based on CPU only! For a better experience, the transitions should be handled by the GPU.
- You cannot call callback methods through another thread
