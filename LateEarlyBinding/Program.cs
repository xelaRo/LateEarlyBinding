using LateEarlyBinding;



var earlyBinding = new EarlyBinding();

// This represents early binding
// The method is found at compile time
earlyBinding.EarlyBindingMethod();


// The method is not found during compile time
// So the compiler will throw an exception
earlyBinding.NotExistingMethod();

// EarlyBinding' does not contain a definition for 'NotExistingMethod'
// and no accessible extension method 'NotExistingMethod' accepting a first argument
// of type 'EarlyBinding' could be found (are you missing a using directive or an assembly reference?)


LateBinding lateBinding = new LateBinding();

// Find method of type LateBindingMethod
// using Reflection and invoke it
var method = lateBinding.GetType().GetMethod("LateBindingMethod");
method.Invoke(lateBinding, null);


// Find non existing method of type NotExistingMethod
// using Reflection and invoke it
var notExistingMethod = lateBinding.GetType().GetMethod("NotExistingMethod");
notExistingMethod.Invoke(lateBinding, null);

// Compile throws exception when NotExistingMethod is not found
// System.NullReferenceException: 'Object reference not set to an instance of an object.'


Console.ReadKey();