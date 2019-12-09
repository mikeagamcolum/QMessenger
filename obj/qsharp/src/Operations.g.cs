#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Qute_Forcer\",\"Name\":\"QuantumRandomNumberGenerator\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs\",\"Position\":{\"Item1\":7,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Qute_Forcer\",\"Name\":\"QuantumRandomNumberGenerator\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs\",\"Position\":{\"Item1\":7,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Qute_Forcer\",\"Name\":\"KeyGenerator\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs\",\"Position\":{\"Item1\":16,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Qute_Forcer\",\"Name\":\"KeyGenerator\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs\",\"Position\":{\"Item1\":16,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Qute_Forcer
{
    public partial class QuantumRandomNumberGenerator : Operation<QVoid, Result>, ICallable
    {
        public QuantumRandomNumberGenerator(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "QuantumRandomNumberGenerator";
        String ICallable.FullName => "Quantum.Qute_Forcer.QuantumRandomNumberGenerator";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        public override Func<QVoid, Result> Body => (__in__) =>
        {
#line hidden
            {
#line 9 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                var q = Allocate.Apply();
#line hidden
                System.Runtime.ExceptionServices.ExceptionDispatchInfo __arg1__ = null;
                try
                {
#line 10 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                    MicrosoftQuantumIntrinsicH.Apply(q);
#line 11 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                    var r = MicrosoftQuantumIntrinsicM.Apply(q);
#line 12 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(q);
#line 13 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                    return r;
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(__arg2__);
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        __arg1__.Throw();
                    }

#line hidden
                    Release.Apply(q);
                }
            }
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__)
        {
            return __m__.Run<QuantumRandomNumberGenerator, QVoid, Result>(QVoid.Instance);
        }
    }

    public partial class KeyGenerator : Operation<QVoid, IQArray<Boolean>>, ICallable
    {
        public KeyGenerator(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "KeyGenerator";
        String ICallable.FullName => "Quantum.Qute_Forcer.KeyGenerator";
        protected ICallable<Result, Boolean> MicrosoftQuantumConvertResultAsBool
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected ICallable<QVoid, Result> QuantumRandomNumberGenerator
        {
            get;
            set;
        }

        public override Func<QVoid, IQArray<Boolean>> Body => (__in__) =>
        {
#line 19 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
            var q = QArray<Qubit>.Create(0L);
#line 20 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
            var bits = QArray<Boolean>.Create(0L);
#line 23 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
            foreach (var inc in new QRange(0L, 1023L))
#line hidden
            {
#line 24 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                bits = QArray<Boolean>.Add(bits, new QArray<Boolean>(MicrosoftQuantumConvertResultAsBool.Apply(QuantumRandomNumberGenerator.Apply(QVoid.Instance))));
            }

#line 28 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
            var prepbase = QArray<Boolean>.Create(0L);
#line 29 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
            foreach (var inc in new QRange(0L, 1023L))
#line hidden
            {
#line hidden
                {
#line 30 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                    var x = Allocate.Apply();
#line hidden
                    System.Runtime.ExceptionServices.ExceptionDispatchInfo __arg1__ = null;
                    try
                    {
#line 31 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                        if ((bits[inc] == true))
                        {
#line 32 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                            MicrosoftQuantumIntrinsicH.Apply(x);
#line 33 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                            prepbase = QArray<Boolean>.Add(prepbase, new QArray<Boolean>(true));
                        }
                        else
                        {
#line 36 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                            MicrosoftQuantumIntrinsicH.Apply(x);
#line 37 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                            var r = MicrosoftQuantumIntrinsicM.Apply(x);
#line 38 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                            prepbase = QArray<Boolean>.Add(prepbase, new QArray<Boolean>(false));
                        }

#line 40 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                        q = QArray<Qubit>.Add(q, new QArray<Qubit>(x));
#line 41 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                        MicrosoftQuantumIntrinsicReset.Apply(x);
                    }
#line hidden
                    catch (Exception __arg2__)
                    {
                        __arg1__ = System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(__arg2__);
                        throw;
                    }
#line hidden
                    finally
                    {
                        if (__arg1__ != null)
                        {
                            __arg1__.Throw();
                        }

#line hidden
                        Release.Apply(x);
                    }
                }
            }

#line 46 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
            var randoms = QArray<Boolean>.Create(0L);
#line 47 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
            var measures = QArray<Boolean>.Create(0L);
#line 48 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
            foreach (var inc in new QRange(0L, 1023L))
#line hidden
            {
#line 49 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                if ((MicrosoftQuantumConvertResultAsBool.Apply(QuantumRandomNumberGenerator.Apply(QVoid.Instance)) == true))
                {
#line 50 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                    randoms = QArray<Boolean>.Add(randoms, new QArray<Boolean>(true));
#line 51 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                    measures = QArray<Boolean>.Add(measures, new QArray<Boolean>(MicrosoftQuantumConvertResultAsBool.Apply(MicrosoftQuantumIntrinsicM.Apply(q[inc]))));
                }
                else
                {
#line 54 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                    randoms = QArray<Boolean>.Add(randoms, new QArray<Boolean>(false));
#line 55 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                    measures = QArray<Boolean>.Add(measures, new QArray<Boolean>(MicrosoftQuantumConvertResultAsBool.Apply(MicrosoftQuantumIntrinsicM.Apply(q[inc]))));
                }
            }

#line 60 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
            var differences = QArray<Boolean>.Create(1024L);
#line 61 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
            foreach (var inc in new QRange(0L, 1023L))
#line hidden
            {
#line 62 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                if ((prepbase[inc] != randoms[inc]))
                {
#line 63 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                    differences = QArray<Boolean>.Add(differences, new QArray<Boolean>(true));
                }
            }

#line 68 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
            var sharedKey = new QArray<Boolean>(randoms?.Copy());
#line 69 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
            foreach (var inc in new QRange(0L, 1023L))
#line hidden
            {
#line 70 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                if (differences[inc])
                {
#line 71 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                    sharedKey = QArray<Boolean>.Add(sharedKey, new QArray<Boolean>(!(randoms[inc])));
                }
                else
                {
#line 74 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
                    sharedKey = QArray<Boolean>.Add(sharedKey, new QArray<Boolean>(randoms[inc]));
                }
            }

#line 78 "C:/Users/Mike/source/repos/Qute%20Forcer/Qute%20Forcer/Operations.qs"
            return sharedKey;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertResultAsBool = this.Factory.Get<ICallable<Result, Boolean>>(typeof(Microsoft.Quantum.Convert.ResultAsBool));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.QuantumRandomNumberGenerator = this.Factory.Get<ICallable<QVoid, Result>>(typeof(QuantumRandomNumberGenerator));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(IQArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Boolean>> Run(IOperationFactory __m__)
        {
            return __m__.Run<KeyGenerator, QVoid, IQArray<Boolean>>(QVoid.Instance);
        }
    }
}