namespace Quantum.Qute_Forcer
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Arithmetic;
	open Microsoft.Quantum.Convert;
	
	operation QuantumRandomNumberGenerator() : Result {
        using(q = Qubit())  { // Allocate a qubit.
		    H(q);             // Put the qubit to superposition. It now has a 50% chance of being 0 or 1.
            let r = M(q);     // Measure the qubit value.
            Reset(q);
            return r;
        }
	}

	operation KeyGenerator() : Unit {
		mutable key = new Bool[1024]; // creates a 1024 character long string
		for(inc in 0 .. 1023){ // loops from 0 to 1023
		}
	}
}
