using HW._15.Task3;
using System.Reflection;

Motorcycle motorcycle = new("Honda");

Console.WriteLine(motorcycle.ToString());

#region Create Instance

Type motoType = typeof(Motorcycle);

Type ctorParameter = typeof(string);

ConstructorInfo ctor = motoType.GetTypeInfo().DeclaredConstructors
     .First(ct => ct.GetParameters().Any() && ct.GetParameters()[0].ParameterType == ctorParameter);

Console.WriteLine();

object[] args1 = new object[] { "Honda" };
object obj = ctor.Invoke(args1);
Console.WriteLine($"Current type - {obj.GetType()}");

Console.WriteLine(obj);

#endregion

#region Write/Read Field

FieldInfo fieldInfo = obj.GetType().GetTypeInfo().GetDeclaredField("_vinNumber");

Console.WriteLine($"Field = {fieldInfo.Name}, isPrivate = {fieldInfo.IsPrivate}");
Console.WriteLine(fieldInfo.GetValue(obj));

fieldInfo.SetValue(obj, 9_999_999);
Console.WriteLine(obj.ToString());

#endregion

/*#region HW Task

Motorcycle moto = new Motorcycle(new DateTime(2022, 02, 02), "Ducati");

Type motoType = typeof(Motorcycle);

Type ctorParameter = typeof(DateTime);

ConstructorInfo ctorMoto = motoType.GetTypeInfo().DeclaredConstructors.
    First(ct => ct.GetParameters().Any() && ct.GetParameters()[0].ParameterType == ctorParameter);

object[] motors = new object[] { new DateTime(2022, 02, 02), "Ducati" };
object firstMoto = ctorMoto.Invoke(motors);

FieldInfo fieldInfo = firstMoto.GetType().GetTypeInfo().GetDeclaredField("_odometer");

Console.WriteLine($"Field = {fieldInfo.Name}, isPrivate = {fieldInfo.IsPrivate}");

fieldInfo.SetValue(moto, 10_000);
Console.WriteLine(moto.ToString());

#endregion*/