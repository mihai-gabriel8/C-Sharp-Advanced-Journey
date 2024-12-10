# C# Delegates

## DelegateBasicExample

## SchoolHRAdministration

## Club Membership Application

Simple Console Application that implements field validation functionality only for Register.

While creating the main views, we are adhering to the dependency inversion principle: Classes should never depend on concretions, but rather depend on abstractions.

This project implements very basic dependency injection functionality

When an object is created using the main view object method, an object derived from the UserLoginView class and an object derived from the UserRegistrationView class is automatically injected into the main view classes Constructor

The main view classes constructors contain two parameters that are of type IView.

Both of the classes injected implement the IView interface.
