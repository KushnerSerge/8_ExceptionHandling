// See https://aka.ms/new-console-template for more information





// ------------------------- -------------------------------------
//Debugger.Break();
using DebugBase;
using System.Diagnostics;


ReadFromAStream.ReadFromAStreamFunc();

Debug.WriteLine("Debug Information Here!!!! FROM MAIN"); // Works just in debug mode
Trace.WriteLine("Release Information Here!!! FROM MAIN "); // Works in both release and debug

// ---------------------- ---------------------------------

#if DEBUG
Console.WriteLine("Debug");

Debug.WriteLine("Debug mode from #DEBUB");
Trace.WriteLine("Release mode from debug");

#else
                Console.WriteLine("Release");
                Debug.WriteLine("Debug mode from #Release");
                Trace.WriteLine("Release mode from Release");
#endif



Console.ReadLine();

// ------------------ --------------------------- -------------------