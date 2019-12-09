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

	operation KeyGenerator() : Bool[] {
		
		mutable q = new Qubit[0];
		mutable bits = new Bool[0];

		// Generate Random Array (Both Parties)
		for(inc in 0 .. 1023) {
			set bits += [ResultAsBool(QuantumRandomNumberGenerator())];
		}

		// Preparation (Sender)
		mutable prepbase = new Bool[0];
		for(inc in 0 .. 1023) {
			using (x = Qubit() ){
				if (bits[inc] == true){ // hadmard/diagonal
					H(x);
					set prepbase += [true];
				}
				else { // computational
					H(x);
					let r = M(x);
					set prepbase += [false];
				}
				set q += [x];
				Reset(x);
			}
		}

		// Measurement (Receiver)
		mutable randoms = new Bool[0];
		mutable measures = new Bool[0];
		for(inc in 0 .. 1023){
			if (ResultAsBool(QuantumRandomNumberGenerator()) == true){ // hadmard/diagonal
				set randoms += [true];
				set measures += [ResultAsBool(M(q[inc]))];
			}
			else { // computational
				set randoms += [false];
				set measures += [ResultAsBool(M(q[inc]))];
			}
		}

		// Compare Results (Both Parties)
		mutable differences = new Bool[1024];
		for(inc in 0 .. 1023) {
			if (prepbase[inc] != randoms[inc]){
				set differences += [true];
			}
		}

		// Create Shared Key (Receiver)
		mutable sharedKey = randoms;
		for(inc in 0 .. 1023) {
			if (differences[inc]){
				set sharedKey += [not randoms[inc]];
			}
			else {
				set sharedKey += [randoms[inc]];
			}
		}

		return sharedKey;
	}
}
