//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
namespace JetBrains.ReSharper.Psi.FSharp {
  public partial interface ICreationExpression : JetBrains.ReSharper.Psi.FSharp.Tree.IExpression {
    JetBrains.ReSharper.Psi.FSharp.ITupleExpression ArgumentList { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression CreatedType { get; }
    JetBrains.ReSharper.Psi.FSharp.ITupleExpression SetArgumentList (JetBrains.ReSharper.Psi.FSharp.ITupleExpression param);
    JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression SetCreatedType (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpression param);
    new JetBrains.ReSharper.Psi.FSharp.ICreationExpressionNode ToTreeNode();
  }
}