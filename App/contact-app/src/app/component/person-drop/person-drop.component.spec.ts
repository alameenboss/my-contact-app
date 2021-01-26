import { DragDropModule } from '@angular/cdk/drag-drop';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { PersonDropComponent } from './person-drop.component';

describe('PersonDropComponent', () => {
  let component: PersonDropComponent;
  let fixture: ComponentFixture<PersonDropComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PersonDropComponent ],
      imports: [
        NoopAnimationsModule,
        DragDropModule,
      ]
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonDropComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should compile', () => {
    expect(component).toBeTruthy();
  });
});
