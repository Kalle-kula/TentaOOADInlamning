﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PlayerFactory
{
	public static IPlayer CreatePlayer(string company)
	{
        IPlayer player = null;
        switch(company)
        {
            case "Netflix":
                player = new NetflixPlayer();
                break;

            case "SF":
                player = new SFPlayer();
                break;                
        }
        return player;
	}
}

