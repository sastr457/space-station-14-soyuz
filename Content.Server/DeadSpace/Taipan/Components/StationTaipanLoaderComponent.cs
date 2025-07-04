﻿// Мёртвый Космос, Licensed under custom terms with restrictions on public hosting and commercial use, full text: https://raw.githubusercontent.com/dead-space-server/space-station-14-fobos/master/LICENSE.TXT

using Content.Server.Maps;
using Robust.Shared.Prototypes;

namespace Content.Server.DeadSpace.Taipan.Components;

[RegisterComponent]
public sealed partial class StationTaipanLoaderComponent : Component
{
    [DataField]
    public ProtoId<GameMapPrototype> Station = "DSTaipan";
}
