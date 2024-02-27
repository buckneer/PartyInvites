﻿using System;
namespace PartyInvites.Models;

public class Repository
{
	public Repository()
	{

	}

	private static List<GuestResponse> responses = new List<GuestResponse>();

	public static IEnumerable<GuestResponse> Responses => responses;

	public static void AddResponse(GuestResponse response)
	{
		responses.Add(response);
	}
}

