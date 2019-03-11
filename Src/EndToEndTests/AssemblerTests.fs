﻿namespace Sacara.EndToEndTests

open System
open ES.Sacara.Ir.Core

module AssemblerTests =

    let run() =
        Utility.assembleInstruction(IrInstruction.Inc, VmInstruction.VmInc)
        Utility.assembleInstruction(IrInstruction.Ret, VmInstruction.VmRet)
        Utility.assembleInstruction(IrInstruction.Nop, VmInstruction.VmNop)
        Utility.assembleInstruction(IrInstruction.Add, VmInstruction.VmAdd)
        Utility.assembleInstructionWithArg(IrInstruction.Push, VmInstruction.VmPushImmediate, "0x12345678")
        Utility.assembleInstructionWithArg(IrInstruction.Push, VmInstruction.VmPushVariable, "some_variable")
        Utility.assembleInstructionWithArg(IrInstruction.Pop, VmInstruction.VmPop, "some_variable")
        Utility.assembleInstruction(IrInstruction.Call, VmInstruction.VmCall)
        Utility.assembleInstruction(IrInstruction.NativeCall, VmInstruction.VmNativeCall)
        Utility.assembleInstruction(IrInstruction.Read, VmInstruction.VmRead)
        Utility.assembleInstruction(IrInstruction.NativeRead, VmInstruction.VmNativeRead)
        Utility.assembleInstruction(IrInstruction.Write, VmInstruction.VmWrite)
        Utility.assembleInstruction(IrInstruction.NativeWrite, VmInstruction.VmNativeWrite)
        Utility.assembleInstruction(IrInstruction.GetIp, VmInstruction.VmGetIp)
        Utility.assembleInstruction(IrInstruction.Jump, VmInstruction.VmJump)
        Utility.assembleInstruction(IrInstruction.JumpIfLess, VmInstruction.VmJumpIfLess)
        Utility.assembleInstruction(IrInstruction.JumpIfLessEquals, VmInstruction.VmJumpIfLessEquals)
        Utility.assembleInstruction(IrInstruction.JumpIfGreater, VmInstruction.VmJumpIfGreater)
        Utility.assembleInstruction(IrInstruction.JumpIfGreaterEquals, VmInstruction.VmJumpIfGreaterEquals)
        Utility.assembleInstruction(IrInstruction.Alloca, VmInstruction.VmAlloca)
        Utility.assembleInstructionWithArg(IrInstruction.Byte, VmInstruction.VmByte, "0x01")
        Utility.assembleInstructionWithArg(IrInstruction.Word, VmInstruction.VmWord, "0x0123")
        Utility.assembleInstructionWithArg(IrInstruction.DoubleWord, VmInstruction.VmDoubleWord, "0x01234567")
        Utility.assembleInstruction(IrInstruction.Halt, VmInstruction.VmHalt)
        Utility.assembleInstruction(IrInstruction.Cmp, VmInstruction.VmCmp)
        Utility.assembleInstruction(IrInstruction.GetSp, VmInstruction.VmGetSp)
        Utility.assembleInstruction(IrInstruction.StackWrite, VmInstruction.VmStackWrite)
        Utility.assembleInstruction(IrInstruction.StackRead, VmInstruction.VmStackRead)
        Utility.assembleInstruction(IrInstruction.Sub, VmInstruction.VmSub)
        Utility.assembleInstruction(IrInstruction.Mul, VmInstruction.VmMul)
        Utility.assembleInstruction(IrInstruction.Div, VmInstruction.VmDiv)
        Utility.assembleInstruction(IrInstruction.And, VmInstruction.VmAnd)
        Utility.assembleInstruction(IrInstruction.ShiftRight, VmInstruction.VmShiftRight)
        Utility.assembleInstruction(IrInstruction.ShiftLeft, VmInstruction.VmShiftLeft)
        Utility.assembleInstruction(IrInstruction.Or, VmInstruction.VmOr)
        Utility.assembleInstruction(IrInstruction.Not, VmInstruction.VmNot)
        Utility.assembleInstruction(IrInstruction.Xor, VmInstruction.VmXor)
        Utility.assembleInstruction(IrInstruction.Nor, VmInstruction.VmNor)
        Utility.assembleInstruction(IrInstruction.SetIp, VmInstruction.VmSetIp)
        Utility.assembleInstruction(IrInstruction.SetSp, VmInstruction.VmSetSp)

