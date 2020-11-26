import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LoginBabaComponent } from './login-baba.component';

describe('LoginBabaComponent', () => {
  let component: LoginBabaComponent;
  let fixture: ComponentFixture<LoginBabaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LoginBabaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LoginBabaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
