import { Component, OnInit } from '@angular/core';
import { Ticket } from '../../Models/Ticket';
import { HttpClient } from '@angular//common/http'
import { GlobalSettings } from '../../base/GlobalSettings';
import { tick } from '@angular/core/src/render3';

let Tickets: Ticket[] = [];

@Component({
  selector: 'app-ticket',
  templateUrl: './ticket.component.html',
  styleUrls: ['./ticket.component.css']
})
export class TicketComponent implements OnInit {

  constructor(private httpClient:HttpClient) { }

  actualizarInfo() {
    console.log(Tickets);
    Tickets = [];
    this.httpClient.get<Ticket>(GlobalSettings.ApiURL+'Ticket/Get').subscribe(ticket=> Tickets.push(ticket));
  }

  ngOnInit() {
    this.httpClient.get<Ticket>(GlobalSettings.ApiURL+'Ticket/Get').subscribe(ticket=> Tickets.push(ticket));
  }

}
