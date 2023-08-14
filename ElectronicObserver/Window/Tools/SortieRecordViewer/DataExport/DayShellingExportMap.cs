﻿using CsvHelper.Configuration;

namespace ElectronicObserver.Window.Tools.SortieRecordViewer.DataExport;

public sealed class DayShellingExportMap : ClassMap<DayShellingExportModel>
{
	public DayShellingExportMap()
	{
		Map(m => m.No).Name(CsvExportResources.No);
		Map(m => m.Date).Name(CsvExportResources.Date);
		Map(m => m.World).Name(CsvExportResources.World);
		Map(m => m.Square).Name(CsvExportResources.Square);
		Map(m => m.Sortie).Name(CsvExportResources.Sortie);
		Map(m => m.Rank).Name(CsvExportResources.Rank);
		Map(m => m.EnemyFleet).Name(CsvExportResources.EnemyFleet);
		Map(m => m.AdmiralLevel).Name(CsvExportResources.AdmiralLevel);
		Map(m => m.PlayerFormation).Name(CsvExportResources.PlayerFormation);
		Map(m => m.EnemyFormation).Name(CsvExportResources.EnemyFormation);
		Map(m => m.PlayerSearch).Name(CsvExportResources.PlayerSearch);
		Map(m => m.EnemySearch).Name(CsvExportResources.EnemySearch);
		Map(m => m.AirState).Name(CsvExportResources.AirState);
		Map(m => m.Engagement).Name(CsvExportResources.Engagement);
		Map(m => m.PlayerContact).Name(CsvExportResources.PlayerContact);
		Map(m => m.EnemyContact).Name(CsvExportResources.EnemyContact);
		Map(m => m.PlayerFlare).Name(CsvExportResources.PlayerFlare);
		Map(m => m.EnemyFlare).Name(CsvExportResources.EnemyFlare);
		Map(m => m.BattleType).Name(CsvExportResources.BattleType);
		Map(m => m.ShipName1).Name(CsvExportResources.ShipName1);
		Map(m => m.ShipName2).Name(CsvExportResources.ShipName2);
		Map(m => m.ShipName3).Name(CsvExportResources.ShipName3);
		Map(m => m.ShipName4).Name(CsvExportResources.ShipName4);
		Map(m => m.ShipName5).Name(CsvExportResources.ShipName5);
		Map(m => m.ShipName6).Name(CsvExportResources.ShipName6);
		Map(m => m.PlayerFleetType).Name(CsvExportResources.PlayerFleetType);
		Map(m => m.BattlePhase).Name(CsvExportResources.BattlePhase);
		Map(m => m.AttackerSide).Name(CsvExportResources.AttackerSide);
		Map(m => m.AttackType).Name(CsvExportResources.AttackType);
		Map(m => m.AttackIndex).Name(CsvExportResources.AttackIndex);
		Map(m => m.DisplayedEquipment1).Name(CsvExportResources.DisplayedEquipment1);
		Map(m => m.DisplayedEquipment2).Name(CsvExportResources.DisplayedEquipment2);
		Map(m => m.DisplayedEquipment3).Name(CsvExportResources.DisplayedEquipment3);
		Map(m => m.HitType).Name(CsvExportResources.HitType);
		Map(m => m.Damage).Name(CsvExportResources.Damage);
		Map(m => m.Protected).Name(CsvExportResources.Protected);
		References<ShipExportMap>(s => s.Attacker, CsvExportResources.PrefixAttacker).Prefix(CsvExportResources.PrefixAttacker);
		References<ShipExportMap>(s => s.Defender, CsvExportResources.PrefixDefender).Prefix(CsvExportResources.PrefixDefender);
		Map(m => m.FleetType).Name(CsvExportResources.FleetType);
		Map(m => m.EnemyFleetType).Name(CsvExportResources.EnemyFleetType);
	}
}
