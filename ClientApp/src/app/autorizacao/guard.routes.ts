import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { UsuarioService } from '../servico/usuario/usuario.service';

@Injectable({
  providedIn: 'root'
})
export class GuardRoutes implements CanActivate {


  constructor(private router: Router, private usuarioService: UsuarioService) {


  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean /*| import("@angular/router").UrlTree | import("rxjs").Observable<boolean | import("@angular/router").UrlTree> | Promise<boolean | import("@angular/router").UrlTree> */ {
    //se usuario autenticado

    if (this.usuarioService.usuario_autenticado()) {
      return true;
    }

    this.router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
    return false;
  }





}
