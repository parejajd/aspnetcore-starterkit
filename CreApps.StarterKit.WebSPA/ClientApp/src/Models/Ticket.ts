import { TicketType } from '../Models/TicketType';
import { Status } from '../Models/Status'
import { Priority } from '../Models/Priority'

export class Ticket {
    Subject: string;
    TypeId: number;
    //Type: TicketType;
    StatusId: number;
    //Status: Status;
    PriorityId: number;
    //Priority: Priority;
    Description: string;
}