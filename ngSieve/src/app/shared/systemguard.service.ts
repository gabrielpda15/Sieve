import { Injectable } from '@angular/core';
import { CanActivate } from '@angular/router';
import { SessionService } from './session.service';

@Injectable({
  providedIn: 'root'
})
export class SystemGuardService implements CanActivate {

  constructor(private session: SessionService) { }

  canActivate(route: import('@angular/router').ActivatedRouteSnapshot,
              state: import('@angular/router').RouterStateSnapshot)
              : boolean |
                import('@angular/router').UrlTree |
                import('rxjs').Observable<boolean |
                import('@angular/router').UrlTree> |
                Promise<boolean | import('@angular/router').UrlTree> {
    return this.session.Token != null;
  }
}
