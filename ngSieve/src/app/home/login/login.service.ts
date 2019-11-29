import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse, HttpHeaders } from '@angular/common/http';
import { map } from 'rxjs/operators';
// import { User } from 'src/app/models/user.model';
import { Observable } from 'rxjs';
// import { API_ENDPOINT, getHttpOptions } from 'src/app/app.consts';
import { stringify } from '@angular/compiler/src/util';
import { SessionService } from 'src/app/shared/session.service';
// import { LoginResponse } from 'src/app/models/loginResponse.model';

@Injectable()
export class LoginService {

  constructor(private http: HttpClient, private session: SessionService) { }

  /*public postLogin(user: User): Observable<LoginResponse> {
    return this.http.post<any>(`${API_ENDPOINT}/login`, JSON.stringify(user), getHttpOptions(null))
                .pipe(map(x => new LoginResponse(x)));
  }*/
}
