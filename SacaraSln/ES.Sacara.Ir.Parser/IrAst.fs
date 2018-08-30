﻿namespace ES.Sacara.Ir.Parser

open System

module IrAst =

    type Expression =
        | Number of Int32
        | Identifier of String

    and Statement =
        | Push of PushType
        | Pop of PopType
        | Procedure of ProcedureType
        | Label of LabelType
        | Call of CallType
        | JumpIf of JumpIfType        
        | Read of ReadType
        | Write of WriteType        
        | Byte of Int32
        | Word of Int32
        | DoubleWord of Int32
        | Alloca
        | Jump
        | Ret
        | Nop
        | GetIp
        | Add
        | Empty
        | Halt
        | Cmp
        | GetSp
        | StackWrite
        | StackRead

    and Program = 
        | Program of Statement list  
        
    and PushType = {
        Operand: Expression
    }

    and CallType = {
        Native: Boolean
    }

    and JumpIfType = {
        JumpIfEquals: Boolean
        JumpIfLess: Boolean
    }

    and ReadType = {
        Native: Boolean
    }

    and WriteType = {
        Native: Boolean
    }

    and PopType = {
        Identifier: String
    }

    and ProcedureType = {
        Name: String
        Body: Statement list
    }

    and LabelType = {
        Name: String
        Statement: Statement
    }