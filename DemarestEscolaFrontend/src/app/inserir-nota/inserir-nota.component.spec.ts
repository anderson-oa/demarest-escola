import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InserirNotaComponent } from './inserir-nota.component';

describe('InserirNotaComponent', () => {
  let component: InserirNotaComponent;
  let fixture: ComponentFixture<InserirNotaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InserirNotaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InserirNotaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
