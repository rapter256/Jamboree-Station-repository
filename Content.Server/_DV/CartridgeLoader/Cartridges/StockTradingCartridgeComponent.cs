// SPDX-FileCopyrightText: 2026 Space Station 14 Contributors
//
// SPDX-License-Identifier: AGPL-3.0-or-later

namespace Content.Server._DV.CartridgeLoader.Cartridges;

[RegisterComponent, Access(typeof(StockTradingCartridgeSystem))]
public sealed partial class StockTradingCartridgeComponent : Component
{
    /// <summary>
    /// Station entity to keep track of
    /// </summary>
    [DataField]
    public EntityUid? Station;
}
