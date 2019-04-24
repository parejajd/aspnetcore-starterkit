import { Component } from '@angular/core';
import { Router } from '@angular/router'
import { ComponentBase } from '../../base/ComponentBase'

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent extends ComponentBase {
  /**
   *
   */
  constructor(router: Router) {
    super(router, false);

  }
}
