using System.Numerics;
using Content.Shared.Atmos;
using Robust.Shared.Prototypes;

namespace Content.Server._NF.Atmos;

[Prototype("gasDeposit")]
public sealed partial class GasDepositPrototype : IPrototype
{
    [ViewVariables]
    [IdDataField]
    public string ID { get; private set; } = default!;

    /// <summary>
    ///     2-vectors (minAmount, maxAmount) in moles of each gas in the deposit.
    /// </summary>
    [DataField]
    public Vector2[] Gases { get; private set; } = new Vector2[Atmospherics.TotalNumberOfGases];
}
