import { Component, OnInit } from '@angular/core';
import { Ticket } from '../../Models/Ticket';
import { HttpClient } from '@angular//common/http'
import { GlobalSettings } from '../../base/GlobalSettings';

@Component({
  selector: 'app-ticket',
  templateUrl: './ticket.component.html',
  styleUrls: ['./ticket.component.css']
})
export class TicketComponent implements OnInit {

  Tickets: Ticket[] = [];
  TextoBoton: string = "Actualizar";

  constructor(private httpClient: HttpClient) { }

  actualizarInfo() {
    this.httpClient.get(GlobalSettings.ApiURL + 'Ticket/Get').toPromise().then((res: Ticket[]) => {
      if (this.Tickets.length == 0) {
        this.Tickets = res;
      } else {
        this.Tickets.push(...res);
      }
    });
    console.log(this.Tickets);
    this.TextoBoton = "Traer mas datos";
  }

  ngOnInit() {
  }

}
