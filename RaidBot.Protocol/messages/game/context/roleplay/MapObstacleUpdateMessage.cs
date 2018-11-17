using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MapObstacleUpdateMessage : NetworkMessage
{

	public const uint Id = 6051;
	public override uint MessageId { get { return Id; } }

	public MapObstacle[] Obstacles { get; set; }

	public MapObstacleUpdateMessage() {}


	public MapObstacleUpdateMessage InitMapObstacleUpdateMessage(MapObstacle[] Obstacles)
	{
		this.Obstacles = Obstacles;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.Obstacles.Length);
		foreach (MapObstacle item in this.Obstacles)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		int ObstaclesLen = reader.ReadShort();
		Obstacles = new MapObstacle[ObstaclesLen];
		for (int i = 0; i < ObstaclesLen; i++)
		{
			this.Obstacles[i] = new MapObstacle();
			this.Obstacles[i].Deserialize(reader);
		}
	}
}
}
