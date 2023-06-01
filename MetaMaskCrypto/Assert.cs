using System.Runtime.CompilerServices;

namespace MetaMaskCrypto;

internal class Assert
{
    public static void NotNull<T>(T obj, [CallerArgumentExpression(nameof(obj))] string name = null!)
    {
        if (obj is null)
        {
            throw new ArgumentNullException($"{name} : {typeof(T)}");
        }
    }
}