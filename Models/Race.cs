using System.ComponentModel.DataAnnotations;
using F1.Interfaces;

namespace F1API.Models;

/****

OBS!

Denne Race-modellen viker fra beskrivelsen nevnt i oppgaveteksten. Etter å ha forhørt meg med lærer
fikk jeg beskjed om at dette gikk fint, siden jeg utarbeider denne eksamen alene og da i hovedsak
bare trenger en tabell i backenden som oppfyller kravene fra eksamenssettet (Driver-modellen gjør dette).

****/

public class Race : IRace
{
    [Key]
    public int Id { get; set; }
    public string? PlayerName { get; set; }
    public int Score { get; set; }
}