import { Router } from '@angular/router';
export class ComponentBase {
    private _Router: Router;
    constructor(private router: Router, private RequiresAuth: boolean) {
        this._Router = router;
        if (RequiresAuth) {
            this.CheckAuthentication();
        }
    }

    CheckAuthentication() {
        if (true) {
            this._Router.navigate(['/Login']);
        }
    }
}