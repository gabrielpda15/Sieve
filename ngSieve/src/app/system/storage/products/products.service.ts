import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

@Injectable()
export class ProductsService {

  constructor() { }

  public get(): Observable<any[]> {
    return of([
      { id: 1, desc: 'Produto A' },
      { id: 2, desc: 'Produto B' },
      { id: 3, desc: 'Produto C' },
      { id: 4, desc: 'Produto D' },
      { id: 5, desc: 'Produto E' },
      { id: 6, desc: 'Produto F' },
      { id: 7, desc: 'Produto G' }
    ]);
  }
}
