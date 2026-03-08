// SPDX-FileCopyrightText: 2026 Space Station 14 Contributors
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Robust.Shared.Serialization;

namespace Content.Shared.CartridgeLoader.Cartridges;

[Serializable, NetSerializable]
public sealed class StockTradingUiMessageEvent(StockTradingUiAction action, int companyIndex, int amount)
    : CartridgeMessageEvent
{
    public readonly StockTradingUiAction Action = action;
    public readonly int CompanyIndex = companyIndex;
    public readonly int Amount = amount;
}

[Serializable, NetSerializable]
public enum StockTradingUiAction
{
    Buy,
    Sell,
}
