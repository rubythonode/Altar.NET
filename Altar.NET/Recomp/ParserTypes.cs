﻿using System;
using System.Collections.Generic;
using System.Linq;
using Altar.Decomp;

namespace Altar.Recomp
{
    public struct OpCodePair
    {
        public EOpCode VersionE;
        public FOpCode VersionF;

        public override string ToString() => VersionE.ToString().ToLowerInvariant() + SR.SLASH + VersionF.ToPrettyString();
    }

    public abstract class Instruction
    {
        public OpCodePair OpCode;

        public override string ToString() => OpCode.ToString();
    }

    public class Label : Instruction
    {
        public IComparable LabelValue;

        public override string ToString() => LabelValue + SR.COLON;
    }

    public class SingleType : Instruction
    {
        public DataType Type;

        public override string ToString() => OpCode + SR.SPACE_S + Type.ToPrettyString();
    }
    public class DoubleType : Instruction
    {
        public DataType Type1;
        public DataType Type2;

        public override string ToString() => OpCode + SR.SPACE_S + Type1.ToPrettyString() + SR.COLON + Type2.ToPrettyString();
    }
    public class Compare : DoubleType
    {
        public ComparisonType ComparisonType;

        public override string ToString() => OpCode + SR.SPACE_S + ComparisonType.ToPrettyString() + SR.SPACE_S + Type1.ToPrettyString() + SR.COLON + Type2.ToPrettyString();
    }
    public class Branch : Instruction
    {
        public object Label;

        public override string ToString() => OpCode + SR.SPACE_S + Label;
    }
    public class Set : DoubleType
    {
        public InstanceType InstanceType;
        public string InstanceName;

        public string TargetVariable;

        public VariableType VariableType;

        public override string ToString() => OpCode + SR.SPACE_S + (InstanceName == null ? InstanceType.ToPrettyString() : InstanceName) + SR.COLON + TargetVariable + VariableType.ToPrettyString();
    }
    public class Call : Instruction
    {
        public DataType ReturnType;

        public long Arguments;
        public string FunctionName;
        public VariableType FunctionType;

        public override string ToString() => OpCode + SR.SPACE_S + ReturnType.ToPrettyString() + SR.COLON + Arguments + SR.SPACE_S + FunctionName + FunctionType.ToPrettyString();
    }
    public class Break : SingleType
    {
        public long Signal;

        public override string ToString() => OpCode + SR.SPACE_S + Signal;
    }

    public abstract class Push : SingleType { }

    public class PushConst : Push
    {
        public object Value;

        public override string ToString() => OpCode + SR.SPACE_S + Type.ToPrettyString() + SR.SPACE_S + Value;
    }
    public class PushVariable : Push
    {
        public InstanceType InstanceType;
        public string InstanceName;

        public string VariableName;

        public VariableType VariableType;

        public override string ToString() => OpCode + SR.SPACE_S + Type.ToPrettyString() + SR.SPACE_S + (InstanceName == null ? InstanceType.ToPrettyString() : InstanceName) + SR.COLON + VariableName + VariableType.ToPrettyString();
    }
}
